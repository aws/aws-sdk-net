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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// This is the response object from the DescribePHIDetectionJob operation.
    /// </summary>
    public partial class DescribePHIDetectionJobResponse : AmazonWebServiceResponse
    {
        private ComprehendMedicalAsyncJobProperties _comprehendMedicalAsyncJobProperties;

        /// <summary>
        /// Gets and sets the property ComprehendMedicalAsyncJobProperties. 
        /// <para>
        /// An object that contains the properties associated with a detection job.
        /// </para>
        /// </summary>
        public ComprehendMedicalAsyncJobProperties ComprehendMedicalAsyncJobProperties
        {
            get { return this._comprehendMedicalAsyncJobProperties; }
            set { this._comprehendMedicalAsyncJobProperties = value; }
        }

        // Check to see if ComprehendMedicalAsyncJobProperties property is set
        internal bool IsSetComprehendMedicalAsyncJobProperties()
        {
            return this._comprehendMedicalAsyncJobProperties != null;
        }

    }
}