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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Flywheel summary information.
    /// </summary>
    public partial class FlywheelSummary
    {
        /// <summary>
        /// Gets and sets the property ActiveModelArn. 
        /// <para>
        /// ARN of the active model version for the flywheel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ActiveModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ActiveModelArn property is set.
        /// </summary>
        internal bool IsSetActiveModelArn() => this.ActiveModelArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the flywheel.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataLakeS3Uri. 
        /// <para>
        /// Amazon S3 URI of the data lake location. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DataLakeS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the DataLakeS3Uri property is set.
        /// </summary>
        internal bool IsSetDataLakeS3Uri() => this.DataLakeS3Uri != null;

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlywheelArn { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelArn property is set.
        /// </summary>
        internal bool IsSetFlywheelArn() => this.FlywheelArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Last modified time for the flywheel.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestFlywheelIteration. 
        /// <para>
        /// The most recent flywheel iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string LatestFlywheelIteration { get; set; }

        /// <summary>
        /// Checks to see if the LatestFlywheelIteration property is set.
        /// </summary>
        internal bool IsSetLatestFlywheelIteration() => this.LatestFlywheelIteration != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the flywheel.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// Model type of the flywheel's model.
        /// </para>
        /// </summary>
        public ModelType ModelType { get; set; }

        /// <summary>
        /// Checks to see if the ModelType property is set.
        /// </summary>
        internal bool IsSetModelType() => this.ModelType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the flywheel.
        /// </para>
        /// </summary>
        public FlywheelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
