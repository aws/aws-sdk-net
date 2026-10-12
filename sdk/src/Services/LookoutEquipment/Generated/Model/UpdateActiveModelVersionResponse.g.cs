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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the UpdateActiveModelVersion operation.
    /// </summary>
    public partial class UpdateActiveModelVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CurrentActiveVersion. 
        /// <para>
        /// The version that is currently active of the machine learning model for which the active
        /// model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? CurrentActiveVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentActiveVersion property is set.
        /// </summary>
        internal bool IsSetCurrentActiveVersion() => this.CurrentActiveVersion.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentActiveVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model version that is the current
        /// active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CurrentActiveVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the CurrentActiveVersionArn property is set.
        /// </summary>
        internal bool IsSetCurrentActiveVersionArn() => this.CurrentActiveVersionArn != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model for which the active
        /// model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model for which the active model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property PreviousActiveVersion. 
        /// <para>
        /// The previous version that was active of the machine learning model for which the active
        /// model version was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? PreviousActiveVersion { get; set; }

        /// <summary>
        /// Checks to see if the PreviousActiveVersion property is set.
        /// </summary>
        internal bool IsSetPreviousActiveVersion() => this.PreviousActiveVersion.HasValue;

        /// <summary>
        /// Gets and sets the property PreviousActiveVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model version that was the
        /// previous active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PreviousActiveVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the PreviousActiveVersionArn property is set.
        /// </summary>
        internal bool IsSetPreviousActiveVersionArn() => this.PreviousActiveVersionArn != null;
    }
}
