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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateModelPackageGroup operation.
    /// Creates a model group. A model group contains a group of model versions.
    /// </summary>
    public partial class CreateModelPackageGroupRequest : AmazonSageMakerRequest
    {
        private string _modelPackageGroupDescription;
        private string _modelPackageGroupName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ModelPackageGroupDescription. 
        /// <para>
        /// A description for the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ModelPackageGroupDescription
        {
            get { return this._modelPackageGroupDescription; }
            set { this._modelPackageGroupDescription = value; }
        }

        // Check to see if ModelPackageGroupDescription property is set
        internal bool IsSetModelPackageGroupDescription()
        {
            return this._modelPackageGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The name of the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelPackageGroupName
        {
            get { return this._modelPackageGroupName; }
            set { this._modelPackageGroupName = value; }
        }

        // Check to see if ModelPackageGroupName property is set
        internal bool IsSetModelPackageGroupName()
        {
            return this._modelPackageGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key value pairs associated with the model group. For more information, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging AWS
        /// resources</a> in the <i>AWS General Reference Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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