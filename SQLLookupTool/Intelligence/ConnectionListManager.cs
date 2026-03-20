using SQLLookupTool.Properties;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

namespace SQLLookupTool.Intelligence
{
    public class ConnectionListManager
    {

        public List<ConnectionListItem> ConnectionList = new List<ConnectionListItem>();

        public ConnectionListManager()
        {
            Load();
        }


        /// <summary>
        /// Loads the connection list from application settings and deserializes it into the current collection.
        /// </summary>
        /// <remarks>If the stored connection list is missing or invalid, the collection is reset to an
        /// empty list. Any errors encountered during deserialization are handled by clearing the collection and writing
        /// an error message to the console.</remarks>
        public void Load()
        {
            // Load the JSON string from settings and deserialize it into the ConnectionList
            string json = Settings.Default.ConnectionList;
            if (!string.IsNullOrEmpty(json))
            {
                try
                {
                    string decodedJson = Base64Helper.Base64ToString(json);
                    this.ConnectionList = JsonSerializer.Deserialize<List<ConnectionListItem>>(decodedJson) ?? new List<ConnectionListItem>();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during deserialization
                    Console.WriteLine("Error loading connection list: " + ex.Message);
                    this.ConnectionList = new List<ConnectionListItem>();
                }
            }
            else
            {
                this.ConnectionList = new List<ConnectionListItem>();
            }
        }


        /// <summary>
        /// Save to Settings
        /// </summary>
        public void Save()
        {
            try
            {

                // Serialize the ConnectionList to JSON and save it to settings
                string json = JsonSerializer.Serialize(this.ConnectionList);

                if (!string.IsNullOrEmpty(json))
                {
                    Settings.Default.ConnectionList = Base64Helper.StringToBase64(json);
                }
                else
                {
                    Settings.Default.ConnectionList = string.Empty;
                }
                Settings.Default.Save();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error saving connection list: " + ex.Message);
            }
        }


        /// <summary>
        /// Add a new connection to the list if it does not already exist. The method checks for duplicates before adding to ensure that each connection is unique in the list.
        /// </summary>
        /// <param name="item">Item to add</param>
        public void AddConnection(ConnectionListItem item)
        {

            if (this.ConnectionList.Contains(item) || string.IsNullOrWhiteSpace(item.ServerName) || this.ConnectionList.Any(x => x.ToString().Equals(item.ToString()))) return;
            this.ConnectionList.Add(item);
        }


        public void RemoveConnection(ConnectionListItem item)
        {
            this.ConnectionList.Remove(item);
        }
    }
}