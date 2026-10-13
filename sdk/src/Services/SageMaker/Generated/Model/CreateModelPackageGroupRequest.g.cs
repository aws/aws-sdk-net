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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateModelPackageGroup operation. Creates a model
    /// group. A model group contains a group of model versions.
    /// </summary>
    public partial class CreateModelPackageGroupRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ManagedConfiguration. 
        /// <para>
        /// The managed configuration of the model package group.
        /// </para>
        /// </summary>
        public ManagedConfiguration ManagedConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedConfiguration() => this.ManagedConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupDescription. 
        /// <para>
        /// A description for the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ModelPackageGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupDescription property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupDescription() => this.ModelPackageGroupDescription != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The name of the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelPackageGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupName property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupName() => this.ModelPackageGroupName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key value pairs associated with the model group. For more information, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
