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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRecommendationTemplate operation.
    /// Creates a new recommendation template.
    /// </summary>
    public partial class CreateRecommendationTemplateRequest : AmazonResilienceHubRequest
    {
        private string _assessmentArn;
        private string _bucketName;
        private string _clientToken;
        private TemplateFormat _format;
        private string _name;
        private List<string> _recommendationIds = new List<string>();
        private List<string> _recommendationTypes = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the assessment. The format for this ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app-assessment/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssessmentArn
        {
            get { return this._assessmentArn; }
            set { this._assessmentArn = value; }
        }

        // Check to see if AssessmentArn property is set
        internal bool IsSetAssessmentArn()
        {
            return this._assessmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket that will contain the recommendation template.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for an idempotency token. A client token is a unique, case-sensitive string of
        /// up to 64 ASCII characters. You should not reuse the same client token for other API
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        public TemplateFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// Identifiers for the recommendations used to create a recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<string> RecommendationIds
        {
            get { return this._recommendationIds; }
            set { this._recommendationIds = value; }
        }

        // Check to see if RecommendationIds property is set
        internal bool IsSetRecommendationIds()
        {
            return this._recommendationIds != null && this._recommendationIds.Count > 0; 
        }

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
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> RecommendationTypes
        {
            get { return this._recommendationTypes; }
            set { this._recommendationTypes = value; }
        }

        // Check to see if RecommendationTypes property is set
        internal bool IsSetRecommendationTypes()
        {
            return this._recommendationTypes != null && this._recommendationTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the resource. A tag is a label that you assign to an Amazon Web
        /// Services resource. Each tag consists of a key/value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}