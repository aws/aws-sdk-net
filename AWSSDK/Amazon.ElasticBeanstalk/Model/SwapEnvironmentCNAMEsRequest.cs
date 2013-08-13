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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the SwapEnvironmentCNAMEs operation.
    /// <para> Swaps the CNAMEs of two environments. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.SwapEnvironmentCNAMEs"/>
    public class SwapEnvironmentCNAMEsRequest : AmazonWebServiceRequest
    {
        private string sourceEnvironmentId;
        private string sourceEnvironmentName;
        private string destinationEnvironmentId;
        private string destinationEnvironmentName;

        /// <summary>
        /// The ID of the source environment. Condition: You must specify at least the <c>SourceEnvironmentID</c> or the <c>SourceEnvironmentName</c>.
        /// You may also specify both. If you specify the <c>SourceEnvironmentId</c>, you must specify the <c>DestinationEnvironmentId</c>.
        ///  
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// The name of the source environment. Condition: You must specify at least the <c>SourceEnvironmentID</c> or the <c>SourceEnvironmentName</c>.
        /// You may also specify both. If you specify the <c>SourceEnvironmentName</c>, you must specify the <c>DestinationEnvironmentName</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// The ID of the destination environment. Condition: You must specify at least the <c>DestinationEnvironmentID</c> or the
        /// <c>DestinationEnvironmentName</c>. You may also specify both. You must specify the <c>SourceEnvironmentId</c> with the
        /// <c>DestinationEnvironmentId</c>.
        ///  
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// The name of the destination environment. Condition: You must specify at least the <c>DestinationEnvironmentID</c> or the
        /// <c>DestinationEnvironmentName</c>. You may also specify both. You must specify the <c>SourceEnvironmentName</c> with the
        /// <c>DestinationEnvironmentName</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
    
