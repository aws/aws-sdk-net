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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details for worker capabilities.
    /// </summary>
    public partial class WorkerCapabilities
    {
        private List<WorkerAmountCapability> _amounts = AWSConfigs.InitializeCollections ? new List<WorkerAmountCapability>() : null;
        private List<WorkerAttributeCapability> _attributes = AWSConfigs.InitializeCollections ? new List<WorkerAttributeCapability>() : null;

        /// <summary>
        /// Gets and sets the property Amounts. 
        /// <para>
        /// The worker capabilities amounts on a list of worker capabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=17)]
        public List<WorkerAmountCapability> Amounts
        {
            get { return this._amounts; }
            set { this._amounts = value; }
        }

        // Check to see if Amounts property is set
        internal bool IsSetAmounts()
        {
            return this._amounts != null && (this._amounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The worker attribute capabilities in the list of attribute capabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=17)]
        public List<WorkerAttributeCapability> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}