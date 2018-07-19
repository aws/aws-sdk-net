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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// The classification type that Amazon Macie applies to the associated S3 resources.
    /// At least one of the classification types (oneTime or continuous) must be specified.
    /// </summary>
    public partial class ClassificationTypeUpdate
    {
        private S3ContinuousClassificationType _continuous;
        private S3OneTimeClassificationType _oneTime;

        /// <summary>
        /// Gets and sets the property Continuous. 
        /// <para>
        /// A continuous classification of the objects that are added to a specified S3 bucket.
        /// Amazon Macie begins performing continuous classification after a bucket is successfully
        /// associated with Amazon Macie. 
        /// </para>
        /// </summary>
        public S3ContinuousClassificationType Continuous
        {
            get { return this._continuous; }
            set { this._continuous = value; }
        }

        // Check to see if Continuous property is set
        internal bool IsSetContinuous()
        {
            return this._continuous != null;
        }

        /// <summary>
        /// Gets and sets the property OneTime. 
        /// <para>
        /// A one-time classification of all of the existing objects in a specified S3 bucket.
        /// 
        /// </para>
        /// </summary>
        public S3OneTimeClassificationType OneTime
        {
            get { return this._oneTime; }
            set { this._oneTime = value; }
        }

        // Check to see if OneTime property is set
        internal bool IsSetOneTime()
        {
            return this._oneTime != null;
        }

    }
}