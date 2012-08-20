using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Properties that define the website configuration for a S3 bucket.
    /// </summary>
    public class WebsiteConfiguration
    {
        string _indexDocumentSuffix;
        string _errorDocument;

        #region IndexDocumentSuffix

        /// <summary>
        /// Gets and sets the IndexDocumentSuffix property.
        /// 
        /// This value is a suffix that is appended to a request that is for a "directory" 
        /// on the website endpoint (e.g. if the suffix is index.html and
        /// you make a request to samplebucket/images/ the data that
        /// is returned will be for the object with the key name
        /// images/index.html)
        /// The suffix must not be empty and must not include a slash
        /// character.
        /// </summary>
        public string IndexDocumentSuffix
        {
            get { return this._indexDocumentSuffix; }
            set { this._indexDocumentSuffix = value; }
        }

        /// <summary>
        /// Sets the IndexDocumentSuffix property for this request.
        /// 
        /// This value is a suffix that is appended to a request that is for a "directory" 
        /// on the website endpoint (e.g. if the suffix is index.html and
        /// you make a request to samplebucket/images/ the data that
        /// is returned will be for the object with the key name
        /// images/index.html)
        /// The suffix must not be empty and must not include a slash
        /// character.
        /// </summary>
        /// <param name="indexDocumentSuffix">The value that IndexDocumentSuffix is set to</param>
        /// <returns>the WebsiteConfiguration with the IndexDocumentSuffix set</returns>
        public WebsiteConfiguration WithIndexDocumentSuffix(string indexDocumentSuffix)
        {
            this._indexDocumentSuffix = indexDocumentSuffix;
            return this;
        }

        /// <summary>
        /// Checks if IndexDocumentSuffix property is set.
        /// </summary>
        /// <returns>true if IndexDocumentSuffix property is set.</returns>
        internal bool IsSetIndexDocumentSuffix()
        {
            return !System.String.IsNullOrEmpty(this._indexDocumentSuffix);
        }

        #endregion


        #region ErrorDocument

        /// <summary>
        /// Gets and sets the ErrorDocument property.
        /// 
        /// The object key name to use when a 4XX class error occurs
        /// </summary>
        public string ErrorDocument
        {
            get { return this._errorDocument; }
            set { this._errorDocument = value; }
        }

        /// <summary>
        /// Sets the ErrorDocument property for this request.
        /// 
        /// The object key name to use when a 4XX class error occurs
        /// </summary>
        /// <param name="errorDocument">The value that ErrorDocument is set to</param>
        /// <returns>the WebsiteConfiguration with the ErrorDocument set</returns>
        public WebsiteConfiguration WithErrorDocument(string errorDocument)
        {
            this._errorDocument = errorDocument;
            return this;
        }

        /// <summary>
        /// Checks if ErrorDocument property is set.
        /// </summary>
        /// <returns>true if ErrorDocument property is set.</returns>
        internal bool IsSetErrorDocument()
        {
            return !System.String.IsNullOrEmpty(this._errorDocument);
        }

        #endregion


        internal string ToXML()
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(sw);

            xmlWriter.WriteStartElement("WebsiteConfiguration", "xmlns='http://s3.amazonaws.com/doc/2006-03-01/'");

            xmlWriter.WriteStartElement("IndexDocument");
            xmlWriter.WriteElementString("Suffix", this.IndexDocumentSuffix);
            xmlWriter.WriteEndElement();

            if (this.IsSetErrorDocument())
            {
                xmlWriter.WriteStartElement("ErrorDocument");
                xmlWriter.WriteElementString("Key", this.ErrorDocument);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            return sw.ToString();
        }

    }
}
