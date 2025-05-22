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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Summary information about a model group.
    /// </summary>
    public partial class ModelPackageGroupSummary
    {
        private DateTime? _creationTime;
        private string _modelPackageGroupArn;
        private string _modelPackageGroupDescription;
        private string _modelPackageGroupName;
        private ModelPackageGroupStatus _modelPackageGroupStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the model group was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelPackageGroupArn
        {
            get { return this._modelPackageGroupArn; }
            set { this._modelPackageGroupArn = value; }
        }

        // Check to see if ModelPackageGroupArn property is set
        internal bool IsSetModelPackageGroupArn()
        {
            return this._modelPackageGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupDescription. 
        /// <para>
        /// A description of the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property ModelPackageGroupStatus. 
        /// <para>
        /// The status of the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelPackageGroupStatus ModelPackageGroupStatus
        {
            get { return this._modelPackageGroupStatus; }
            set { this._modelPackageGroupStatus = value; }
        }

        // Check to see if ModelPackageGroupStatus property is set
        internal bool IsSetModelPackageGroupStatus()
        {
            return this._modelPackageGroupStatus != null;
        }

    }
}