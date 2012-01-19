/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the SwapEnvironmentCNAMEs operation.
    /// 
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.SwapEnvironmentCNAMEs"/>
    public class SwapEnvironmentCNAMEsRequest : AmazonWebServiceRequest
    {
        private string sourceEnvironmentId;
        private string sourceEnvironmentName;
        private string destinationEnvironmentId;
        private string destinationEnvironmentName;
        public string SourceEnvironmentId
        {
            get { return this.sourceEnvironmentId; }
            set { this.sourceEnvironmentId = value; }
        }

        /// <summary>
        /// Sets the SourceEnvironmentId property
        /// </summary>
        /// <param name="sourceEnvironmentId">The value to set for the SourceEnvironmentId property </param>
        /// <returns>this instance</returns>
        public SwapEnvironmentCNAMEsRequest WithSourceEnvironmentId(string sourceEnvironmentId)
        {
            this.sourceEnvironmentId = sourceEnvironmentId;
            return this;
        }
            

        // Check to see if SourceEnvironmentId property is set
        internal bool IsSetSourceEnvironmentId()
        {
            return this.sourceEnvironmentId != null;       
        }
        public string SourceEnvironmentName
        {
            get { return this.sourceEnvironmentName; }
            set { this.sourceEnvironmentName = value; }
        }

        /// <summary>
        /// Sets the SourceEnvironmentName property
        /// </summary>
        /// <param name="sourceEnvironmentName">The value to set for the SourceEnvironmentName property </param>
        /// <returns>this instance</returns>
        public SwapEnvironmentCNAMEsRequest WithSourceEnvironmentName(string sourceEnvironmentName)
        {
            this.sourceEnvironmentName = sourceEnvironmentName;
            return this;
        }
            

        // Check to see if SourceEnvironmentName property is set
        internal bool IsSetSourceEnvironmentName()
        {
            return this.sourceEnvironmentName != null;       
        }
        public string DestinationEnvironmentId
        {
            get { return this.destinationEnvironmentId; }
            set { this.destinationEnvironmentId = value; }
        }

        /// <summary>
        /// Sets the DestinationEnvironmentId property
        /// </summary>
        /// <param name="destinationEnvironmentId">The value to set for the DestinationEnvironmentId property </param>
        /// <returns>this instance</returns>
        public SwapEnvironmentCNAMEsRequest WithDestinationEnvironmentId(string destinationEnvironmentId)
        {
            this.destinationEnvironmentId = destinationEnvironmentId;
            return this;
        }
            

        // Check to see if DestinationEnvironmentId property is set
        internal bool IsSetDestinationEnvironmentId()
        {
            return this.destinationEnvironmentId != null;       
        }
        public string DestinationEnvironmentName
        {
            get { return this.destinationEnvironmentName; }
            set { this.destinationEnvironmentName = value; }
        }

        /// <summary>
        /// Sets the DestinationEnvironmentName property
        /// </summary>
        /// <param name="destinationEnvironmentName">The value to set for the DestinationEnvironmentName property </param>
        /// <returns>this instance</returns>
        public SwapEnvironmentCNAMEsRequest WithDestinationEnvironmentName(string destinationEnvironmentName)
        {
            this.destinationEnvironmentName = destinationEnvironmentName;
            return this;
        }
            

        // Check to see if DestinationEnvironmentName property is set
        internal bool IsSetDestinationEnvironmentName()
        {
            return this.destinationEnvironmentName != null;       
        }
    }
}
    
