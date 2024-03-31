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
    /// DocumentBodyParagraphWithHighlight
    /// </summary>
    [DataContract]
    public partial class DocumentBodyParagraphWithHighlight :  IEquatable<DocumentBodyParagraphWithHighlight>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyParagraphWithHighlight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBodyParagraphWithHighlight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyParagraphWithHighlight" /> class.
        /// </summary>
        /// <param name="Blocks">The list of blocks for the paragraph. (required).</param>
        /// <param name="Properties">The properties for the paragraph..</param>
        public DocumentBodyParagraphWithHighlight(List<DocumentContentBlockWithHighlight> Blocks = null, DocumentBodyParagraphProperties Properties = null)
        {
            this.Blocks = Blocks;
            this.Properties = Properties;
            
        }
        


        /// <summary>
        /// The list of blocks for the paragraph.
        /// </summary>
        /// <value>The list of blocks for the paragraph.</value>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public List<DocumentContentBlockWithHighlight> Blocks { get; set; }



        /// <summary>
        /// The properties for the paragraph.
        /// </summary>
        /// <value>The properties for the paragraph.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public DocumentBodyParagraphProperties Properties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyParagraphWithHighlight {\n");

            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as DocumentBodyParagraphWithHighlight);
        }

        /// <summary>
        /// Returns true if DocumentBodyParagraphWithHighlight instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyParagraphWithHighlight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyParagraphWithHighlight other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.SequenceEqual(other.Blocks)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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
                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }

}
