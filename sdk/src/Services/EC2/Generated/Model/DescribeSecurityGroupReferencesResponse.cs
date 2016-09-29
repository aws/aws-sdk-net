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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeSecurityGroupReferences operation.
    /// </summary>
    public partial class DescribeSecurityGroupReferencesResponse : AmazonWebServiceResponse
    {
        private List<SecurityGroupReference> _securityGroupReferenceSet = new List<SecurityGroupReference>();

        /// <summary>
        /// Gets and sets the property SecurityGroupReferenceSet. 
        /// <para>
        /// Information about the VPCs with the referencing security groups.
        /// </para>
        /// </summary>
        public List<SecurityGroupReference> SecurityGroupReferenceSet
        {
            get { return this._securityGroupReferenceSet; }
            set { this._securityGroupReferenceSet = value; }
        }

        // Check to see if SecurityGroupReferenceSet property is set
        internal bool IsSetSecurityGroupReferenceSet()
        {
            return this._securityGroupReferenceSet != null && this._securityGroupReferenceSet.Count > 0; 
        }

    }
}