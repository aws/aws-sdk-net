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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApp operation. Creates an Resilience Hub
    /// application. An Resilience Hub application is a collection of Amazon Web Services
    /// resources structured to prevent and recover Amazon Web Services application disruptions.
    /// To describe a Resilience Hub application, you provide an application name, resources
    /// from one or more CloudFormation stacks, Resource Groups, Terraform state files, AppRegistry
    /// applications, and an appropriate resiliency policy. In addition, you can also add
    /// resources that are located on Amazon Elastic Kubernetes Service (Amazon EKS) clusters
    /// as optional resources. For more information about the number of resources supported
    /// per application, see <a href="https://docs.aws.amazon.com/general/latest/gr/resiliencehub.html#limits_resiliencehub">Service
    /// quotas</a>. <para> After you create an Resilience Hub application, you publish it
    /// so that you can run a resiliency assessment on it. You can then use recommendations
    /// from the assessment to improve resiliency by running another assessment, comparing
    /// results, and then iterating the process until you achieve your goals for recovery
    /// time objective (RTO) and recovery point objective (RPO). </para>
    /// </summary>
    public partial class CreateAppRequest : AmazonResilienceHubRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentSchedule. 
        /// <para>
        ///  Assessment execution schedule with 'Daily' or 'Disabled' values. 
        /// </para>
        /// </summary>
        public AppAssessmentScheduleType AssessmentSchedule { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentSchedule property is set.
        /// </summary>
        internal bool IsSetAssessmentSchedule() => this.AssessmentSchedule != null;

        /// <summary>
        /// Gets and sets the property AwsApplicationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of Resource Groups group that is integrated with an AppRegistry
        /// application. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string AwsApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsApplicationArn property is set.
        /// </summary>
        internal bool IsSetAwsApplicationArn() => this.AwsApplicationArn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for an idempotency token. A client token is a unique, case-sensitive string of
        /// up to 64 ASCII characters. You should not reuse the same client token for other API
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for an app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventSubscriptions. 
        /// <para>
        /// The list of events you would like to subscribe and get notification for. Currently,
        /// Resilience Hub supports only <b>Drift detected</b> and <b>Scheduled assessment failure</b>
        /// events notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<EventSubscription> EventSubscriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<EventSubscription>() : null;

        /// <summary>
        /// Checks to see if the EventSubscriptions property is set.
        /// </summary>
        internal bool IsSetEventSubscriptions() => this.EventSubscriptions != null && (this.EventSubscriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Defines the roles and credentials that Resilience Hub would use while creating the
        /// application, importing its resources, and running an assessment.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resiliency policy. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:resiliency-policy/<c>policy-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the resource. A tag is a label that you assign to an Amazon Web Services
        /// resource. Each tag consists of a key/value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
