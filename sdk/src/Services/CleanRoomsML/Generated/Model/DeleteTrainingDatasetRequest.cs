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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTrainingDataset operation.
    /// Specifies a training dataset that you want to delete. You can't delete a training
    /// dataset if there are any audience models that depend on the training dataset. In Clean
    /// Rooms ML, the <c>TrainingDataset</c> is metadata that points to a Glue table, which
    /// is read only during <c>AudienceModel</c> creation. This action deletes the metadata.
    /// </summary>
    public partial class DeleteTrainingDatasetRequest : AmazonCleanRoomsMLRequest
    {
        private string _trainingDatasetArn;

        /// <summary>
        /// Gets and sets the property TrainingDatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training dataset that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrainingDatasetArn
        {
            get { return this._trainingDatasetArn; }
            set { this._trainingDatasetArn = value; }
        }

        // Check to see if TrainingDatasetArn property is set
        internal bool IsSetTrainingDatasetArn()
        {
            return this._trainingDatasetArn != null;
        }

    }
}