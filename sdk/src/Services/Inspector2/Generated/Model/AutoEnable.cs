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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Represents which scan types are automatically enabled for new members of your Amazon
    /// Inspector organization.
    /// </summary>
    public partial class AutoEnable
    {
        private bool? _ec2;
        private bool? _ecr;
        private bool? _lambda;

        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// Represents whether Amazon EC2 scans are automatically enabled for new members of your
        /// Amazon Inspector organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Ec2
        {
            get { return this._ec2.GetValueOrDefault(); }
            set { this._ec2 = value; }
        }

        // Check to see if Ec2 property is set
        internal bool IsSetEc2()
        {
            return this._ec2.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ecr. 
        /// <para>
        /// Represents whether Amazon ECR scans are automatically enabled for new members of your
        /// Amazon Inspector organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Ecr
        {
            get { return this._ecr.GetValueOrDefault(); }
            set { this._ecr = value; }
        }

        // Check to see if Ecr property is set
        internal bool IsSetEcr()
        {
            return this._ecr.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// Represents whether AWS Lambda scans are automatically enabled for new members of your
        /// Amazon Inspector organization. 
        /// </para>
        /// </summary>
        public bool Lambda
        {
            get { return this._lambda.GetValueOrDefault(); }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda.HasValue; 
        }

    }
}