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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the CreateShare operation.
    /// </summary>
    public partial class CreateShareResponse : AmazonWebServiceResponse
    {
        private string _shareId;
        private string _shareName;
        private ShareStatus _status;

        /// <summary>
        /// Gets and sets the property ShareId. 
        /// <para>
        /// The ID that HealthOmics generates for the share.
        /// </para>
        /// </summary>
        public string ShareId
        {
            get { return this._shareId; }
            set { this._shareId = value; }
        }

        // Check to see if ShareId property is set
        internal bool IsSetShareId()
        {
            return this._shareId != null;
        }

        /// <summary>
        /// Gets and sets the property ShareName. 
        /// <para>
        /// The name of the share.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ShareName
        {
            get { return this._shareName; }
            set { this._shareName = value; }
        }

        // Check to see if ShareName property is set
        internal bool IsSetShareName()
        {
            return this._shareName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the share.
        /// </para>
        /// </summary>
        public ShareStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}