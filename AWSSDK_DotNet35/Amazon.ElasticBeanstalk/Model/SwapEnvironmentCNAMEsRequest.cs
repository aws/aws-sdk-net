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
    public partial class SwapEnvironmentCNAMEsRequest : AmazonElasticBeanstalkRequest
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

        // Check to see if DestinationEnvironmentName property is set
        internal bool IsSetDestinationEnvironmentName()
        {
            return this.destinationEnvironmentName != null;
        }

    }
}
    
