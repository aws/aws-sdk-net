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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the StartADAssessment operation.
    /// Initiates a directory assessment to validate your self-managed AD environment for
    /// hybrid domain join. The assessment checks compatibility and connectivity of the self-managed
    /// AD environment.
    /// 
    ///  
    /// <para>
    /// A directory assessment is automatically created when you create a hybrid directory.
    /// There are two types of assessments: <c>CUSTOMER</c> and <c>SYSTEM</c>. Your Amazon
    /// Web Services account has a limit of 100 <c>CUSTOMER</c> directory assessments.
    /// </para>
    ///  
    /// <para>
    /// The assessment process typically takes 30 minutes or more to complete. The assessment
    /// process is asynchronous and you can monitor it with <c>DescribeADAssessment</c>.
    /// </para>
    ///  
    /// <para>
    /// The <c>InstanceIds</c> must have a one-to-one correspondence with <c>CustomerDnsIps</c>,
    /// meaning that if the IP address for instance i-10243410 is 10.24.34.100 and the IP
    /// address for instance i-10243420 is 10.24.34.200, then the input arrays must maintain
    /// the same order relationship, either [10.24.34.100, 10.24.34.200] paired with [i-10243410,
    /// i-10243420] or [10.24.34.200, 10.24.34.100] paired with [i-10243420, i-10243410].
    /// </para>
    ///  
    /// <para>
    /// Note: You must provide exactly one <c>DirectoryId</c> or <c>AssessmentConfiguration</c>.
    /// </para>
    /// </summary>
    public partial class StartADAssessmentRequest : AmazonDirectoryServiceRequest
    {
        private AssessmentConfiguration _assessmentConfiguration;
        private string _directoryId;

        /// <summary>
        /// Gets and sets the property AssessmentConfiguration. 
        /// <para>
        /// Configuration parameters for the directory assessment, including DNS server information,
        /// domain name, Amazon VPC subnet, and Amazon Web Services System Manager managed node
        /// details.
        /// </para>
        /// </summary>
        public AssessmentConfiguration AssessmentConfiguration
        {
            get { return this._assessmentConfiguration; }
            set { this._assessmentConfiguration = value; }
        }

        // Check to see if AssessmentConfiguration property is set
        internal bool IsSetAssessmentConfiguration()
        {
            return this._assessmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for which to perform the assessment. This should be
        /// an existing directory. If the assessment is not for an existing directory, this parameter
        /// should be omitted.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

    }
}