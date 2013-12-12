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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// <para>Represents the output of a <c>ListStreams</c> operation.</para>
    /// </summary>
    public partial class ListStreamsResult
    {
        
        private List<string> streamNames = new List<string>();
        private bool? hasMoreStreams;

        /// <summary>
        /// The names of the streams that are associated with the AWS account making the <c>ListStreams</c> request.
        ///  
        /// </summary>
        public List<string> StreamNames
        {
            get { return this.streamNames; }
            set { this.streamNames = value; }
        }
        /// <summary>
        /// Adds elements to the StreamNames collection
        /// </summary>
        /// <param name="streamNames">The values to add to the StreamNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStreamsResult WithStreamNames(params string[] streamNames)
        {
            foreach (string element in streamNames)
            {
                this.streamNames.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the StreamNames collection
        /// </summary>
        /// <param name="streamNames">The values to add to the StreamNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStreamsResult WithStreamNames(IEnumerable<string> streamNames)
        {
            foreach (string element in streamNames)
            {
                this.streamNames.Add(element);
            }

            return this;
        }

        // Check to see if StreamNames property is set
        internal bool IsSetStreamNames()
        {
            return this.streamNames.Count > 0;
        }

        /// <summary>
        /// If set to <c>true</c>, there are more streams available to list.
        ///  
        /// </summary>
        public bool HasMoreStreams
        {
            get { return this.hasMoreStreams ?? default(bool); }
            set { this.hasMoreStreams = value; }
        }

        /// <summary>
        /// Sets the HasMoreStreams property
        /// </summary>
        /// <param name="hasMoreStreams">The value to set for the HasMoreStreams property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStreamsResult WithHasMoreStreams(bool hasMoreStreams)
        {
            this.hasMoreStreams = hasMoreStreams;
            return this;
        }
            

        // Check to see if HasMoreStreams property is set
        internal bool IsSetHasMoreStreams()
        {
            return this.hasMoreStreams.HasValue;
        }
    }
}
