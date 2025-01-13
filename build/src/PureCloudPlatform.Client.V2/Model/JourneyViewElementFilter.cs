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
    /// A set of filters on an element within a journey view
    /// </summary>
    [DataContract]
    public partial class JourneyViewElementFilter :  IEquatable<JourneyViewElementFilter>
    {
        /// <summary>
        /// Boolean operation to apply to the provided predicates and clauses. Valid values: And
        /// </summary>
        /// <value>Boolean operation to apply to the provided predicates and clauses. Valid values: And</value>
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
            /// Enum And for "And"
            /// </summary>
            [EnumMember(Value = "And")]
            And
        }
        /// <summary>
        /// Boolean operation to apply to the provided predicates and clauses. Valid values: And
        /// </summary>
        /// <value>Boolean operation to apply to the provided predicates and clauses. Valid values: And</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElementFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyViewElementFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElementFilter" /> class.
        /// </summary>
        /// <param name="Type">Boolean operation to apply to the provided predicates and clauses. Valid values: And (required).</param>
        /// <param name="Predicates">predicates.</param>
        /// <param name="NumberPredicates">numberPredicates.</param>
        public JourneyViewElementFilter(TypeEnum? Type = null, List<JourneyViewElementFilterPredicate> Predicates = null, List<JourneyViewElementFilterNumberPredicate> NumberPredicates = null)
        {
            this.Type = Type;
            this.Predicates = Predicates;
            this.NumberPredicates = NumberPredicates;
            
        }
        




        /// <summary>
        /// predicates
        /// </summary>
        /// <value>predicates</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<JourneyViewElementFilterPredicate> Predicates { get; set; }



        /// <summary>
        /// numberPredicates
        /// </summary>
        /// <value>numberPredicates</value>
        [DataMember(Name="numberPredicates", EmitDefaultValue=false)]
        public List<JourneyViewElementFilterNumberPredicate> NumberPredicates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewElementFilter {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
            sb.Append("  NumberPredicates: ").Append(NumberPredicates).Append("\n");
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
            return this.Equals(obj as JourneyViewElementFilter);
        }

        /// <summary>
        /// Returns true if JourneyViewElementFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewElementFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewElementFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
                ) &&
                (
                    this.NumberPredicates == other.NumberPredicates ||
                    this.NumberPredicates != null &&
                    this.NumberPredicates.SequenceEqual(other.NumberPredicates)
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

                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();

                if (this.NumberPredicates != null)
                    hash = hash * 59 + this.NumberPredicates.GetHashCode();

                return hash;
            }
        }
    }

}
