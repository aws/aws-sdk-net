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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the ImportLens operation.
    /// Import a new custom lens or update an existing custom lens.
    /// 
    ///  
    /// <para>
    /// To update an existing custom lens, specify its ARN as the <code>LensAlias</code>.
    /// If no ARN is specified, a new custom lens is created.
    /// </para>
    ///  
    /// <para>
    /// The new or updated lens will have a status of <code>DRAFT</code>. The lens cannot
    /// be applied to workloads or shared with other Amazon Web Services accounts until it's
    /// published with <a>CreateLensVersion</a>.
    /// </para>
    ///  
    /// <para>
    /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
    /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A custom lens cannot exceed 500 KB in size.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Disclaimer</b> 
    /// </para>
    ///  
    /// <para>
    /// Do not include or gather personal identifiable information (PII) of end users or other
    /// identifiable individuals in or via your custom lenses. If your custom lens or those
    /// shared with you and used in your account do include or collect PII you are responsible
    /// for: ensuring that the included PII is processed in accordance with applicable law,
    /// providing adequate privacy notices, and obtaining necessary consents for processing
    /// such data.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ImportLensRequest : AmazonWellArchitectedRequest
    {
        private string _clientRequestToken;
        private string _jsonString;
        private string _lensAlias;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property JSONString. 
        /// <para>
        /// The JSON representation of a lens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=500000)]
        public string JSONString
        {
            get { return this._jsonString; }
            set { this._jsonString = value; }
        }

        // Check to see if JSONString property is set
        internal bool IsSetJSONString()
        {
            return this._jsonString != null;
        }

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LensAlias
        {
            get { return this._lensAlias; }
            set { this._lensAlias = value; }
        }

        // Check to see if LensAlias property is set
        internal bool IsSetLensAlias()
        {
            return this._lensAlias != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate to a lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}