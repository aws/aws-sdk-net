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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the SearchThings operation. Searches for things associated
    /// with the specified entity. You can search by both device and device model. <para>
    /// For example, if two different devices, camera1 and camera2, implement the camera device
    /// model, the user can associate thing1 to camera1 and thing2 to camera2. <c>SearchThings(camera2)</c>
    /// will return only thing2, but <c>SearchThings(camera)</c> will return both thing1 and
    /// thing2. </para> <para> This action searches for exact matches and doesn't perform
    /// partial text matching. </para>
    /// </summary>
    public partial class SearchThingsRequest : AmazonIoTThingsGraphRequest
    {
        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity to which the things are associated.
        /// </para>
        ///  
        /// <para>
        /// The IDs should be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>urn:tdm:REGION/ACCOUNT ID/default:device:DEVICENAME</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 160)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceVersion. 
        /// <para>
        /// The version of the user's namespace. Defaults to the latest version of the user's
        /// namespace.
        /// </para>
        /// </summary>
        public long? NamespaceVersion { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceVersion property is set.
        /// </summary>
        internal bool IsSetNamespaceVersion() => this.NamespaceVersion.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies the next page of results. Use this when you're paginating
        /// results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
