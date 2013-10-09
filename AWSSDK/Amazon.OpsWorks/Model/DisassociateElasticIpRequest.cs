/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateElasticIp operation.
    /// <para>Disassociates an Elastic IP address from its instance. The address remains registered with the stack. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html"
    /// >http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DisassociateElasticIp"/>
    public class DisassociateElasticIpRequest : AmazonWebServiceRequest
    {
        private string elasticIp;

        /// <summary>
        /// The Elastic IP address.
        ///  
        /// </summary>
        public string ElasticIp
        {
            get { return this.elasticIp; }
            set { this.elasticIp = value; }
        }

        /// <summary>
        /// Sets the ElasticIp property
        /// </summary>
        /// <param name="elasticIp">The value to set for the ElasticIp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisassociateElasticIpRequest WithElasticIp(string elasticIp)
        {
            this.elasticIp = elasticIp;
            return this;
        }
            

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this.elasticIp != null;
        }
    }
}
    
