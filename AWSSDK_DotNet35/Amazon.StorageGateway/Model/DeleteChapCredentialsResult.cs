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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// </summary>
    public partial class DeleteChapCredentialsResult : AmazonWebServiceResponse
    {
        
        private string targetARN;
        private string initiatorName;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the target.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 800</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TargetARN
        {
            get { return this.targetARN; }
            set { this.targetARN = value; }
        }

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this.targetARN != null;
        }

        /// <summary>
        /// The iSCSI initiator that connects to the target.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[0-9a-z:.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InitiatorName
        {
            get { return this.initiatorName; }
            set { this.initiatorName = value; }
        }

        // Check to see if InitiatorName property is set
        internal bool IsSetInitiatorName()
        {
            return this.initiatorName != null;
        }
    }
}
