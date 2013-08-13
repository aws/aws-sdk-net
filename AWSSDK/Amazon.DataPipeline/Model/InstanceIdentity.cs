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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para> <para>Identity information for the Amazon EC2 instance that is hosting the task runner. You can get this value by calling a metadata
    /// URI from the EC2 instance. For more information, go to Instance Metadata in the <i>Amazon Elastic Compute Cloud User Guide.</i> Passing in
    /// this value proves that your task runner is running on an EC2 instance, and ensures the proper AWS Data Pipeline service charges are applied
    /// to your pipeline.</para> </para>
    /// </summary>
    public class InstanceIdentity
    {
        
        private string document;
        private string signature;

        /// <summary>
        /// A description of an Amazon EC2 instance that is generated when the instance is launched and exposed to the instance via the instance
        /// metadata service in the form of a JSON representation of an object.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Document
        {
            get { return this.document; }
            set { this.document = value; }
        }

        /// <summary>
        /// Sets the Document property
        /// </summary>
        /// <param name="document">The value to set for the Document property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceIdentity WithDocument(string document)
        {
            this.document = document;
            return this;
        }
            

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this.document != null;
        }

        /// <summary>
        /// A signature which can be used to verify the accuracy and authenticity of the information provided in the instance identity document.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Signature
        {
            get { return this.signature; }
            set { this.signature = value; }
        }

        /// <summary>
        /// Sets the Signature property
        /// </summary>
        /// <param name="signature">The value to set for the Signature property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceIdentity WithSignature(string signature)
        {
            this.signature = signature;
            return this;
        }
            

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this.signature != null;
        }
    }
}
