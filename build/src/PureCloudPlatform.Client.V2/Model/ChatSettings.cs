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
    /// ChatSettings
    /// </summary>
    [DataContract]
    public partial class ChatSettings :  IEquatable<ChatSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSettings" /> class.
        /// </summary>
        /// <param name="MessageRetentionPeriodDays">Retention time for messages in days, expressed as int in the range [10,3650].</param>
        /// <param name="ReactionsEnabled">Reactions enabled for org.</param>
        public ChatSettings(int? MessageRetentionPeriodDays = null, bool? ReactionsEnabled = null)
        {
            this.MessageRetentionPeriodDays = MessageRetentionPeriodDays;
            this.ReactionsEnabled = ReactionsEnabled;
            
        }
        


        /// <summary>
        /// Retention time for messages in days, expressed as int in the range [10,3650]
        /// </summary>
        /// <value>Retention time for messages in days, expressed as int in the range [10,3650]</value>
        [DataMember(Name="messageRetentionPeriodDays", EmitDefaultValue=false)]
        public int? MessageRetentionPeriodDays { get; set; }



        /// <summary>
        /// Reactions enabled for org
        /// </summary>
        /// <value>Reactions enabled for org</value>
        [DataMember(Name="reactionsEnabled", EmitDefaultValue=false)]
        public bool? ReactionsEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatSettings {\n");

            sb.Append("  MessageRetentionPeriodDays: ").Append(MessageRetentionPeriodDays).Append("\n");
            sb.Append("  ReactionsEnabled: ").Append(ReactionsEnabled).Append("\n");
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
            return this.Equals(obj as ChatSettings);
        }

        /// <summary>
        /// Returns true if ChatSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageRetentionPeriodDays == other.MessageRetentionPeriodDays ||
                    this.MessageRetentionPeriodDays != null &&
                    this.MessageRetentionPeriodDays.Equals(other.MessageRetentionPeriodDays)
                ) &&
                (
                    this.ReactionsEnabled == other.ReactionsEnabled ||
                    this.ReactionsEnabled != null &&
                    this.ReactionsEnabled.Equals(other.ReactionsEnabled)
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
                if (this.MessageRetentionPeriodDays != null)
                    hash = hash * 59 + this.MessageRetentionPeriodDays.GetHashCode();

                if (this.ReactionsEnabled != null)
                    hash = hash * 59 + this.ReactionsEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
