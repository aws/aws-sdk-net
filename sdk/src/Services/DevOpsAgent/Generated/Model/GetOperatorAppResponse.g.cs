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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// This is the response object from the GetOperatorApp operation.
    /// </summary>
    public partial class GetOperatorAppResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Iam.
        /// </summary>
        public IamAuthConfiguration Iam { get; set; }

        /// <summary>
        /// Checks to see if the Iam property is set.
        /// </summary>
        internal bool IsSetIam() => this.Iam != null;

        /// <summary>
        /// Gets and sets the property Idc.
        /// </summary>
        public IdcAuthConfiguration Idc { get; set; }

        /// <summary>
        /// Checks to see if the Idc property is set.
        /// </summary>
        internal bool IsSetIdc() => this.Idc != null;

        /// <summary>
        /// Gets and sets the property Idp.
        /// </summary>
        public IdpAuthConfiguration Idp { get; set; }

        /// <summary>
        /// Checks to see if the Idp property is set.
        /// </summary>
        internal bool IsSetIdp() => this.Idp != null;

        /// <summary>
        /// Gets and sets the property OperatorAppUrl. 
        /// <para>
        /// The URL for operators to access the Operator App
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string OperatorAppUrl { get; set; }

        /// <summary>
        /// Checks to see if the OperatorAppUrl property is set.
        /// </summary>
        internal bool IsSetOperatorAppUrl() => this.OperatorAppUrl != null;
    }
}
