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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutConformancePack operation.
    /// Creates or updates a conformance pack. A conformance pack is a collection of AWS Config
    /// rules that can be easily deployed in an account and a region and across AWS Organization.
    /// 
    ///  
    /// <para>
    /// This API creates a service linked role <code>AWSServiceRoleForConfigConforms</code>
    /// in your account. The service linked role is created only when the role does not exist
    /// in your account. 
    /// </para>
    ///  <note> 
    /// <para>
    /// You must specify either the <code>TemplateS3Uri</code> or the <code>TemplateBody</code>
    /// parameter, but not both. If you provide both AWS Config uses the <code>TemplateS3Uri</code>
    /// parameter and ignores the <code>TemplateBody</code> parameter.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutConformancePackRequest : AmazonConfigServiceRequest
    {
        private List<ConformancePackInputParameter> _conformancePackInputParameters = new List<ConformancePackInputParameter>();
        private string _conformancePackName;
        private string _deliveryS3Bucket;
        private string _deliveryS3KeyPrefix;
        private string _templateBody;
        private string _templateS3Uri;

        /// <summary>
        /// Gets and sets the property ConformancePackInputParameters. 
        /// <para>
        /// A list of <code>ConformancePackInputParameter</code> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public List<ConformancePackInputParameter> ConformancePackInputParameters
        {
            get { return this._conformancePackInputParameters; }
            set { this._conformancePackInputParameters = value; }
        }

        // Check to see if ConformancePackInputParameters property is set
        internal bool IsSetConformancePackInputParameters()
        {
            return this._conformancePackInputParameters != null && this._conformancePackInputParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3Bucket. 
        /// <para>
        /// AWS Config stores intermediate files while processing conformance pack template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string DeliveryS3Bucket
        {
            get { return this._deliveryS3Bucket; }
            set { this._deliveryS3Bucket = value; }
        }

        // Check to see if DeliveryS3Bucket property is set
        internal bool IsSetDeliveryS3Bucket()
        {
            return this._deliveryS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3KeyPrefix. 
        /// <para>
        /// The prefix for the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DeliveryS3KeyPrefix
        {
            get { return this._deliveryS3KeyPrefix; }
            set { this._deliveryS3KeyPrefix = value; }
        }

        // Check to see if DeliveryS3KeyPrefix property is set
        internal bool IsSetDeliveryS3KeyPrefix()
        {
            return this._deliveryS3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// A string containing full conformance pack template body. Structure containing the
        /// template body with a minimum length of 1 byte and a maximum length of 51,200 bytes.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only use a YAML template with one resource type, that is, config rule and
        /// a remediation action. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=51200)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateS3Uri. 
        /// <para>
        /// Location of file containing the template body (<code>s3://bucketname/prefix</code>).
        /// The uri must point to the conformance pack template (max size: 300 KB) that is located
        /// in an Amazon S3 bucket in the same region as the conformance pack. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have access to read Amazon S3 bucket.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TemplateS3Uri
        {
            get { return this._templateS3Uri; }
            set { this._templateS3Uri = value; }
        }

        // Check to see if TemplateS3Uri property is set
        internal bool IsSetTemplateS3Uri()
        {
            return this._templateS3Uri != null;
        }

    }
}