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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the StartMLModelTrainingJob operation.
    /// </summary>
    public partial class StartMLModelTrainingJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private long? _creationTimeInMillis;
        private string _id;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the new model training job.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimeInMillis. 
        /// <para>
        /// The model training job creation time, in milliseconds.
        /// </para>
        /// </summary>
        public long? CreationTimeInMillis
        {
            get { return this._creationTimeInMillis; }
            set { this._creationTimeInMillis = value; }
        }

        // Check to see if CreationTimeInMillis property is set
        internal bool IsSetCreationTimeInMillis()
        {
            return this._creationTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the new model training job.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}