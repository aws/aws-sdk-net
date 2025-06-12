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
    /// Container for the parameters to the BatchGetTriggers operation.
    /// Returns a list of resource metadata for a given list of trigger names. After calling
    /// the <c>ListTriggers</c> operation, you can call this operation to access the data
    /// to which you have been granted permissions. This operation supports all IAM permissions,
    /// including permission conditions that uses tags.
    /// </summary>
    public partial class BatchGetTriggersRequest : AmazonGlueRequest
    {
        private List<string> _triggerNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TriggerNames. 
        /// <para>
        /// A list of trigger names, which may be the names returned from the <c>ListTriggers</c>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TriggerNames
        {
            get { return this._triggerNames; }
            set { this._triggerNames = value; }
        }

        // Check to see if TriggerNames property is set
        internal bool IsSetTriggerNames()
        {
            return this._triggerNames != null && (this._triggerNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}