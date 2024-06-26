/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing details of a representation to update or create a Lake Formation
    /// view.
    /// </summary>
    public partial class ViewRepresentationInput
    {
        private ViewDialect _dialect;
        private string _dialectVersion;
        private string _validationConnection;
        private string _viewExpandedText;
        private string _viewOriginalText;

        /// <summary>
        /// Gets and sets the property Dialect. 
        /// <para>
        /// A parameter that specifies the engine type of a specific representation.
        /// </para>
        /// </summary>
        public ViewDialect Dialect
        {
            get { return this._dialect; }
            set { this._dialect = value; }
        }

        // Check to see if Dialect property is set
        internal bool IsSetDialect()
        {
            return this._dialect != null;
        }

        /// <summary>
        /// Gets and sets the property DialectVersion. 
        /// <para>
        /// A parameter that specifies the version of the engine of a specific representation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DialectVersion
        {
            get { return this._dialectVersion; }
            set { this._dialectVersion = value; }
        }

        // Check to see if DialectVersion property is set
        internal bool IsSetDialectVersion()
        {
            return this._dialectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationConnection. 
        /// <para>
        /// The name of the connection to be used to validate the specific representation of the
        /// view.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ValidationConnection
        {
            get { return this._validationConnection; }
            set { this._validationConnection = value; }
        }

        // Check to see if ValidationConnection property is set
        internal bool IsSetValidationConnection()
        {
            return this._validationConnection != null;
        }

        /// <summary>
        /// Gets and sets the property ViewExpandedText. 
        /// <para>
        /// A string that represents the SQL query that describes the view with expanded resource
        /// ARNs
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
        public string ViewExpandedText
        {
            get { return this._viewExpandedText; }
            set { this._viewExpandedText = value; }
        }

        // Check to see if ViewExpandedText property is set
        internal bool IsSetViewExpandedText()
        {
            return this._viewExpandedText != null;
        }

        /// <summary>
        /// Gets and sets the property ViewOriginalText. 
        /// <para>
        /// A string that represents the original SQL query that describes the view.
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
        public string ViewOriginalText
        {
            get { return this._viewOriginalText; }
            set { this._viewOriginalText = value; }
        }

        // Check to see if ViewOriginalText property is set
        internal bool IsSetViewOriginalText()
        {
            return this._viewOriginalText != null;
        }

    }
}