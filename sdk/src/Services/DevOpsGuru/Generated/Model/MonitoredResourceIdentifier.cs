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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the resource that is being monitored, including the name of the
    /// resource, the type of resource, and whether or not permission is given to DevOps Guru
    /// to access that resource.
    /// </summary>
    public partial class MonitoredResourceIdentifier
    {
        private DateTime? _lastUpdated;
        private string _monitoredResourceName;
        private ResourceCollection _resourceCollection;
        private ResourcePermission _resourcePermission;
        private string _type;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        ///  The time at which DevOps Guru last updated this resource. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoredResourceName. 
        /// <para>
        ///  The name of the resource being monitored. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string MonitoredResourceName
        {
            get { return this._monitoredResourceName; }
            set { this._monitoredResourceName = value; }
        }

        // Check to see if MonitoredResourceName property is set
        internal bool IsSetMonitoredResourceName()
        {
            return this._monitoredResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePermission. 
        /// <para>
        ///  The permission status of a resource. 
        /// </para>
        /// </summary>
        public ResourcePermission ResourcePermission
        {
            get { return this._resourcePermission; }
            set { this._resourcePermission = value; }
        }

        // Check to see if ResourcePermission property is set
        internal bool IsSetResourcePermission()
        {
            return this._resourcePermission != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of resource being monitored. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}