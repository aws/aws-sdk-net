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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the ListServiceVersions operation.
    /// </summary>
    public partial class ListServiceVersionsResponse : AmazonWebServiceResponse
    {
        private List<DependentService> _dependentServices = AWSConfigs.InitializeCollections ? new List<DependentService>() : null;
        private string _nextToken;
        private ServiceName _serviceName;
        private List<ServiceVersion> _serviceVersions = AWSConfigs.InitializeCollections ? new List<ServiceVersion>() : null;

        /// <summary>
        /// Gets and sets the property DependentServices. 
        /// <para>
        /// A list of names and versions of dependant services of the service for which the system
        /// provided supported versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DependentService> DependentServices
        {
            get { return this._dependentServices; }
            set { this._dependentServices = value; }
        }

        // Check to see if DependentServices property is set
        internal bool IsSetDependentServices()
        {
            return this._dependentServices != null && (this._dependentServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Because HTTP requests are stateless, this is the starting point of the next list of
        /// returned <c>ListServiceVersionsResult</c> results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service for which the system provided supported versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceName ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceVersions. 
        /// <para>
        /// A list of supported versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ServiceVersion> ServiceVersions
        {
            get { return this._serviceVersions; }
            set { this._serviceVersions = value; }
        }

        // Check to see if ServiceVersions property is set
        internal bool IsSetServiceVersions()
        {
            return this._serviceVersions != null && (this._serviceVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}