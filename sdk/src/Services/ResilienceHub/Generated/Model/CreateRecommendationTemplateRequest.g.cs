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
    /// Container for the parameters to the CreateRecommendationTemplate operation. Creates
    /// a new recommendation template for the Resilience Hub application.
    /// </summary>
    public partial class CreateRecommendationTemplateRequest : AmazonResilienceHubRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the assessment. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app-assessment/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssessmentArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentArn property is set.
        /// </summary>
        internal bool IsSetAssessmentArn() => this.AssessmentArn != null;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket that will contain the recommendation template.
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format for the recommendation template.
        /// </para>
        ///  <dl> <dt>CfnJson</dt> <dd> 
        /// <para>
        /// The template is CloudFormation JSON.
        /// </para>
        ///  </dd> <dt>CfnYaml</dt> <dd> 
        /// <para>
        /// The template is CloudFormation YAML.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public TemplateFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// Identifiers for the recommendations used to create a recommendation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<string> RecommendationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendationIds property is set.
        /// </summary>
        internal bool IsSetRecommendationIds() => this.RecommendationIds != null && (this.RecommendationIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationTypes. 
        /// <para>
        /// An array of strings that specify the recommendation template type or types.
        /// </para>
        ///  <dl> <dt>Alarm</dt> <dd> 
        /// <para>
        /// The template is an <a>AlarmRecommendation</a> template.
        /// </para>
        ///  </dd> <dt>Sop</dt> <dd> 
        /// <para>
        /// The template is a <a>SopRecommendation</a> template.
        /// </para>
        ///  </dd> <dt>Test</dt> <dd> 
        /// <para>
        /// The template is a <a>TestRecommendation</a> template.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> RecommendationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendationTypes property is set.
        /// </summary>
        internal bool IsSetRecommendationTypes() => this.RecommendationTypes != null && (this.RecommendationTypes.Count > 0 || !AWSConfigs.InitializeCollections);

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
