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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
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
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// The result of the application tag that's applied to a resource.
    /// </summary>
    public partial class ApplicationTagResult
    {
        private ApplicationTagStatus _applicationTagStatus;
        private string _errorMessage;
        private string _nextToken;
        private List<ResourcesListItem> _resources = AWSConfigs.InitializeCollections ? new List<ResourcesListItem>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationTagStatus. 
        /// <para>
        ///  The application tag is in the process of being applied to a resource, was successfully
        /// applied to a resource, or failed to apply to a resource. 
        /// </para>
        /// </summary>
        public ApplicationTagStatus ApplicationTagStatus
        {
            get { return this._applicationTagStatus; }
            set { this._applicationTagStatus = value; }
        }

        // Check to see if ApplicationTagStatus property is set
        internal bool IsSetApplicationTagStatus()
        {
            return this._applicationTagStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The message returned if the call fails. 
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A unique pagination token for each page of results. Make the call again with the
        /// returned token to retrieve the next page of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        ///  The resources associated with an application 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourcesListItem> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}