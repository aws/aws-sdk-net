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
    /// This is the response object from the DescribeThingGroup operation.
    /// </summary>
    public partial class DescribeThingGroupResponse : AmazonWebServiceResponse
    {
        private string _indexName;
        private string _queryString;
        private string _queryVersion;
        private DynamicGroupStatus _status;
        private string _thingGroupArn;
        private string _thingGroupId;
        private ThingGroupMetadata _thingGroupMetadata;
        private string _thingGroupName;
        private ThingGroupProperties _thingGroupProperties;
        private long? _version;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The dynamic thing group index name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The dynamic thing group search query string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The dynamic thing group query version.
        /// </para>
        /// </summary>
        public string QueryVersion
        {
            get { return this._queryVersion; }
            set { this._queryVersion = value; }
        }

        // Check to see if QueryVersion property is set
        internal bool IsSetQueryVersion()
        {
            return this._queryVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The dynamic thing group status.
        /// </para>
        /// </summary>
        public DynamicGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupArn. 
        /// <para>
        /// The thing group ARN.
        /// </para>
        /// </summary>
        public string ThingGroupArn
        {
            get { return this._thingGroupArn; }
            set { this._thingGroupArn = value; }
        }

        // Check to see if ThingGroupArn property is set
        internal bool IsSetThingGroupArn()
        {
            return this._thingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupId. 
        /// <para>
        /// The thing group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingGroupId
        {
            get { return this._thingGroupId; }
            set { this._thingGroupId = value; }
        }

        // Check to see if ThingGroupId property is set
        internal bool IsSetThingGroupId()
        {
            return this._thingGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupMetadata. 
        /// <para>
        /// Thing group metadata.
        /// </para>
        /// </summary>
        public ThingGroupMetadata ThingGroupMetadata
        {
            get { return this._thingGroupMetadata; }
            set { this._thingGroupMetadata = value; }
        }

        // Check to see if ThingGroupMetadata property is set
        internal bool IsSetThingGroupMetadata()
        {
            return this._thingGroupMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupName. 
        /// <para>
        /// The name of the thing group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingGroupName
        {
            get { return this._thingGroupName; }
            set { this._thingGroupName = value; }
        }

        // Check to see if ThingGroupName property is set
        internal bool IsSetThingGroupName()
        {
            return this._thingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupProperties. 
        /// <para>
        /// The thing group properties.
        /// </para>
        /// </summary>
        public ThingGroupProperties ThingGroupProperties
        {
            get { return this._thingGroupProperties; }
            set { this._thingGroupProperties = value; }
        }

        // Check to see if ThingGroupProperties property is set
        internal bool IsSetThingGroupProperties()
        {
            return this._thingGroupProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the thing group.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}