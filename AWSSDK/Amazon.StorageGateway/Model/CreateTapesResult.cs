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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>CreateTapeOutput</para>
    /// </summary>
    public partial class CreateTapesResult
    {
        
        private List<string> tapeARNs = new List<string>();

        /// <summary>
        /// A list of unique Amazon Resource Named (ARN) the represents the virtual tapes that were created.
        ///  
        /// </summary>
        public List<string> TapeARNs
        {
            get { return this.tapeARNs; }
            set { this.tapeARNs = value; }
        }
        /// <summary>
        /// Adds elements to the TapeARNs collection
        /// </summary>
        /// <param name="tapeARNs">The values to add to the TapeARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTapesResult WithTapeARNs(params string[] tapeARNs)
        {
            foreach (string element in tapeARNs)
            {
                this.tapeARNs.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TapeARNs collection
        /// </summary>
        /// <param name="tapeARNs">The values to add to the TapeARNs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTapesResult WithTapeARNs(IEnumerable<string> tapeARNs)
        {
            foreach (string element in tapeARNs)
            {
                this.tapeARNs.Add(element);
            }

            return this;
        }

        // Check to see if TapeARNs property is set
        internal bool IsSetTapeARNs()
        {
            return this.tapeARNs.Count > 0;
        }
    }
}
