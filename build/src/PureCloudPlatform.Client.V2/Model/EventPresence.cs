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
    /// A Presence event.
    /// </summary>
    [DataContract]
    public partial class EventPresence :  IEquatable<EventPresence>
    {
        /// <summary>
        /// Describes the type of Presence event.
        /// </summary>
        /// <value>Describes the type of Presence event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Join for "Join"
            /// </summary>
            [EnumMember(Value = "Join")]
            Join,
            
            /// <summary>
            /// Enum Disconnect for "Disconnect"
            /// </summary>
            [EnumMember(Value = "Disconnect")]
            Disconnect,
            
            /// <summary>
            /// Enum Clear for "Clear"
            /// </summary>
            [EnumMember(Value = "Clear")]
            Clear,
            
            /// <summary>
            /// Enum Signin for "SignIn"
            /// </summary>
            [EnumMember(Value = "SignIn")]
            Signin
        }
        /// <summary>
        /// Describes the type of Presence event.
        /// </summary>
        /// <value>Describes the type of Presence event.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventPresence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventPresence() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventPresence" /> class.
        /// </summary>
        /// <param name="Type">Describes the type of Presence event. (required).</param>
        public EventPresence(TypeEnum? Type = null)
        {
            this.Type = Type;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventPresence {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as EventPresence);
        }

        /// <summary>
        /// Returns true if EventPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of EventPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventPresence other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
