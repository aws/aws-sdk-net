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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the PutEventConfiguration operation.
    /// </summary>
    public partial class PutEventConfigurationResponse : AmazonWebServiceResponse
    {
        private List<ContextKeySelector> _contextKeySelectors = AWSConfigs.InitializeCollections ? new List<ContextKeySelector>() : null;
        private string _eventDataStoreArn;
        private MaxEventSize _maxEventSize;

        /// <summary>
        /// Gets and sets the property ContextKeySelectors. 
        /// <para>
        /// The list of context key selectors that are configured for the event data store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<ContextKeySelector> ContextKeySelectors
        {
            get { return this._contextKeySelectors; }
            set { this._contextKeySelectors = value; }
        }

        // Check to see if ContextKeySelectors property is set
        internal bool IsSetContextKeySelectors()
        {
            return this._contextKeySelectors != null && (this._contextKeySelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) or ID suffix of the ARN of the event data store for
        /// which the event configuration settings were updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStoreArn
        {
            get { return this._eventDataStoreArn; }
            set { this._eventDataStoreArn = value; }
        }

        // Check to see if EventDataStoreArn property is set
        internal bool IsSetEventDataStoreArn()
        {
            return this._eventDataStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxEventSize. 
        /// <para>
        /// The maximum allowed size for events stored in the specified event data store.
        /// </para>
        /// </summary>
        public MaxEventSize MaxEventSize
        {
            get { return this._maxEventSize; }
            set { this._maxEventSize = value; }
        }

        // Check to see if MaxEventSize property is set
        internal bool IsSetMaxEventSize()
        {
            return this._maxEventSize != null;
        }

    }
}