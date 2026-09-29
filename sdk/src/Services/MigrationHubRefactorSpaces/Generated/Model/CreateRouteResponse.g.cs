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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// This is the response object from the CreateRoute operation.
    /// </summary>
    public partial class CreateRouteResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application in which the route is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the route. The format for this ARN is <c>arn:aws:refactor-spaces:<i>region</i>:<i>account-id</i>:<i>resource-type/resource-id</i>
        /// </c>. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedByAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the route creator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string CreatedByAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByAccountId property is set.
        /// </summary>
        internal bool IsSetCreatedByAccountId() => this.CreatedByAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that indicates when the route is created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// A timestamp that indicates when the route was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the route owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property RouteId. 
        /// <para>
        /// The unique identifier of the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string RouteId { get; set; }

        /// <summary>
        /// Checks to see if the RouteId property is set.
        /// </summary>
        internal bool IsSetRouteId() => this.RouteId != null;

        /// <summary>
        /// Gets and sets the property RouteType. 
        /// <para>
        /// The route type of the route.
        /// </para>
        /// </summary>
        public RouteType RouteType { get; set; }

        /// <summary>
        /// Checks to see if the RouteType property is set.
        /// </summary>
        internal bool IsSetRouteType() => this.RouteType != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of service in which the route is created. Traffic that matches this route is
        /// forwarded to this service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route. Activation state only allows <c>ACTIVE</c> or <c>INACTIVE</c>
        /// as user inputs. <c>FAILED</c> is a route state that is system generated.
        /// </para>
        /// </summary>
        public RouteState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the created route. A tag is a label that you assign to an Amazon
        /// Web Services resource. Each tag consists of a key-value pair. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UriPathRoute. 
        /// <para>
        /// Configuration for the URI path route type. 
        /// </para>
        /// </summary>
        public UriPathRouteInput UriPathRoute { get; set; }

        /// <summary>
        /// Checks to see if the UriPathRoute property is set.
        /// </summary>
        internal bool IsSetUriPathRoute() => this.UriPathRoute != null;
    }
}
