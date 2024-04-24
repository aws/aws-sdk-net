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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAdapterVersion operation.
    /// Deletes an Amazon Textract adapter version. Requires that you specify both an AdapterId
    /// and a AdapterVersion. Deletes the adapter version specified by the AdapterId and the
    /// AdapterVersion.
    /// </summary>
    public partial class DeleteAdapterVersionRequest : AmazonTextractRequest
    {
        private string _adapterId;
        private string _adapterVersion;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string containing a unique ID for the adapter version that will be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=1011)]
        public string AdapterId
        {
            get { return this._adapterId; }
            set { this._adapterId = value; }
        }

        // Check to see if AdapterId property is set
        internal bool IsSetAdapterId()
        {
            return this._adapterId != null;
        }

        /// <summary>
        /// Gets and sets the property AdapterVersion. 
        /// <para>
        /// Specifies the adapter version to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AdapterVersion
        {
            get { return this._adapterVersion; }
            set { this._adapterVersion = value; }
        }

        // Check to see if AdapterVersion property is set
        internal bool IsSetAdapterVersion()
        {
            return this._adapterVersion != null;
        }

    }
}