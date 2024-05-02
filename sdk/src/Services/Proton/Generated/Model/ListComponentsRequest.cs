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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the ListComponents operation.
    /// List components with summary data. You can filter the result list by environment,
    /// service, or a single service instance.
    /// 
    ///  
    /// <para>
    /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListComponentsRequest : AmazonProtonRequest
    {
        private string _environmentName;
        private int? _maxResults;
        private string _nextToken;
        private string _serviceInstanceName;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of an environment for result list filtering. Proton returns components associated
        /// with the environment or attached to service instances running in it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of components to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next component in the array of components,
        /// after the list of components that was previously requested.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of a service instance for result list filtering. Proton returns the component
        /// attached to the service instance, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ServiceInstanceName
        {
            get { return this._serviceInstanceName; }
            set { this._serviceInstanceName = value; }
        }

        // Check to see if ServiceInstanceName property is set
        internal bool IsSetServiceInstanceName()
        {
            return this._serviceInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of a service for result list filtering. Proton returns components attached
        /// to service instances of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}