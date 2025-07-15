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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// This is the response object from the BatchRemoveChannelRoleFromAccessors operation.
    /// </summary>
    public partial class BatchRemoveChannelRoleFromAccessorsResponse : AmazonWebServiceResponse
    {
        private List<BatchError> _errors = AWSConfigs.InitializeCollections ? new List<BatchError>() : null;
        private List<string> _removedAccessorIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of errors that occurred when roles were removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemovedAccessorIds. 
        /// <para>
        /// An array of successfully updated identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<string> RemovedAccessorIds
        {
            get { return this._removedAccessorIds; }
            set { this._removedAccessorIds = value; }
        }

        // Check to see if RemovedAccessorIds property is set
        internal bool IsSetRemovedAccessorIds()
        {
            return this._removedAccessorIds != null && (this._removedAccessorIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}