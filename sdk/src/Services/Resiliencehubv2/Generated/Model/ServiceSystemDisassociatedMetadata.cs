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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Metadata for a service system disassociated event.
    /// </summary>
    public partial class ServiceSystemDisassociatedMetadata
    {
        private string _systemArn;
        private string _systemId;
        private string _systemName;

        /// <summary>
        /// Gets and sets the property SystemArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string SystemArn
        {
            get { return this._systemArn; }
            set { this._systemArn = value; }
        }

        // Check to see if SystemArn property is set
        internal bool IsSetSystemArn()
        {
            return this._systemArn != null;
        }

        /// <summary>
        /// Gets and sets the property SystemId. 
        /// <para>
        /// The identifier of the disassociated system.
        /// </para>
        /// </summary>
        public string SystemId
        {
            get { return this._systemId; }
            set { this._systemId = value; }
        }

        // Check to see if SystemId property is set
        internal bool IsSetSystemId()
        {
            return this._systemId != null;
        }

        /// <summary>
        /// Gets and sets the property SystemName. 
        /// <para>
        /// The name of the disassociated system.
        /// </para>
        /// </summary>
        public string SystemName
        {
            get { return this._systemName; }
            set { this._systemName = value; }
        }

        // Check to see if SystemName property is set
        internal bool IsSetSystemName()
        {
            return this._systemName != null;
        }

    }
}