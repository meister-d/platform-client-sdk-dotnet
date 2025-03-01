using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// InsightsSettingsRequest
    /// </summary>
    [DataContract]
    public partial class InsightsSettingsRequest :  IEquatable<InsightsSettingsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsSettingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InsightsSettingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsSettingsRequest" /> class.
        /// </summary>
        /// <param name="Enabled">The AI Insights setting (required).</param>
        public InsightsSettingsRequest(bool? Enabled = null)
        {
            this.Enabled = Enabled;
            
        }
        


        /// <summary>
        /// The AI Insights setting
        /// </summary>
        /// <value>The AI Insights setting</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsightsSettingsRequest {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InsightsSettingsRequest);
        }

        /// <summary>
        /// Returns true if InsightsSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InsightsSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                return hash;
            }
        }
    }

}
