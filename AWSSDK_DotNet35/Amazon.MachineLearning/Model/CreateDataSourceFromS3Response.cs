/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */

using System;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Configuration for accessing Amazon CreateDataSourceFromS3 service
    /// </summary>
    public partial class CreateDataSourceFromS3Response : CreateDataSourceFromS3Result
    {
        /// <summary>
        /// Gets and sets the CreateDataSourceFromS3Result property.
        /// Represents the output of a CreateDataSourceFromS3 operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the CreateDataSourceFromS3Result class are now available on the CreateDataSourceFromS3Response class. You should use the properties on CreateDataSourceFromS3Response instead of accessing them through CreateDataSourceFromS3Result.")]
        public CreateDataSourceFromS3Result CreateDataSourceFromS3Result
        {
            get
            {
                return this;
            }
        }
    }
}