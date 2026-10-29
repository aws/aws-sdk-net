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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDynamicThingGroup operation. Creates a dynamic
    /// thing group. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateDynamicThingGroup</a>
    /// action. </para>
    /// </summary>
    public partial class CreateDynamicThingGroupRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The dynamic thing group index name.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently one index is supported: <c>AWS_Things</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The dynamic thing group search query string.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/iot/latest/developerguide/query-syntax.html">Query
        /// Syntax</a> for information about query string syntax.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The dynamic thing group query version.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently one query version is supported: "2017-09-30". If not specified, the query
        /// version defaults to this value.
        /// </para>
        ///  </note>
        /// </summary>
        public string QueryVersion { get; set; }

        /// <summary>
        /// Checks to see if the QueryVersion property is set.
        /// </summary>
        internal bool IsSetQueryVersion() => this.QueryVersion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the dynamic thing group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThingGroupName. 
        /// <para>
        /// The dynamic thing group name to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupName property is set.
        /// </summary>
        internal bool IsSetThingGroupName() => this.ThingGroupName != null;

        /// <summary>
        /// Gets and sets the property ThingGroupProperties. 
        /// <para>
        /// The dynamic thing group properties.
        /// </para>
        /// </summary>
        public ThingGroupProperties ThingGroupProperties { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupProperties property is set.
        /// </summary>
        internal bool IsSetThingGroupProperties() => this.ThingGroupProperties != null;
    }
}
