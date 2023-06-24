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
    /// Container for the parameters to the ExportLens operation.
    /// Export an existing lens.
    /// 
    ///  
    /// <para>
    /// Only the owner of a lens can export it. Lenses provided by Amazon Web Services (Amazon
    /// Web Services Official Content) cannot be exported.
    /// </para>
    ///  
    /// <para>
    /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
    /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
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
    public partial class ExportLensRequest : AmazonWellArchitectedRequest
    {
        private string _lensAlias;
        private string _lensVersion;

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property LensVersion. 
        /// <para>
        /// The lens version to be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string LensVersion
        {
            get { return this._lensVersion; }
            set { this._lensVersion = value; }
        }

        // Check to see if LensVersion property is set
        internal bool IsSetLensVersion()
        {
            return this._lensVersion != null;
        }

    }
}