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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListDomainConfigurations operation.
    /// Gets a list of domain configurations for the user. This list is sorted alphabetically
    /// by domain configuration name.
    /// 
    ///  <note> 
    /// <para>
    /// The domain configuration feature is in public preview and is subject to change.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListDomainConfigurationsRequest : AmazonIoTRequest
    {
        private string _marker;
        private int? _pageSize;
        private ServiceType _serviceType;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The result page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The type of service delivered by the endpoint.
        /// </para>
        /// </summary>
        public ServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

    }
}