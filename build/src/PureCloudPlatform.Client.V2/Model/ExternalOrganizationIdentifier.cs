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
    /// ExternalOrganizationIdentifier
    /// </summary>
    [DataContract]
    public partial class ExternalOrganizationIdentifier :  IEquatable<ExternalOrganizationIdentifier>
    {
        /// <summary>
        /// The type of this identifier
        /// </summary>
        /// <value>The type of this identifier</value>
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
            /// Enum Externalid for "ExternalId"
            /// </summary>
            [EnumMember(Value = "ExternalId")]
            Externalid
        }
        /// <summary>
        /// The type of this identifier
        /// </summary>
        /// <value>The type of this identifier</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOrganizationIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalOrganizationIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOrganizationIdentifier" /> class.
        /// </summary>
        /// <param name="Type">The type of this identifier (required).</param>
        /// <param name="Value">The string value of the identifier. Will vary in syntax by type. (required).</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ExternalSource">The External Source ID of the identifier.</param>
        public ExternalOrganizationIdentifier(TypeEnum? Type = null, string Value = null, DateTime? DateCreated = null, ExternalSource ExternalSource = null)
        {
            this.Type = Type;
            this.Value = Value;
            this.DateCreated = DateCreated;
            this.ExternalSource = ExternalSource;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The string value of the identifier. Will vary in syntax by type.
        /// </summary>
        /// <value>The string value of the identifier. Will vary in syntax by type.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The External Source ID of the identifier
        /// </summary>
        /// <value>The External Source ID of the identifier</value>
        [DataMember(Name="externalSource", EmitDefaultValue=false)]
        public ExternalSource ExternalSource { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalOrganizationIdentifier {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ExternalOrganizationIdentifier);
        }

        /// <summary>
        /// Returns true if ExternalOrganizationIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalOrganizationIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalOrganizationIdentifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ExternalSource == other.ExternalSource ||
                    this.ExternalSource != null &&
                    this.ExternalSource.Equals(other.ExternalSource)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ExternalSource != null)
                    hash = hash * 59 + this.ExternalSource.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
