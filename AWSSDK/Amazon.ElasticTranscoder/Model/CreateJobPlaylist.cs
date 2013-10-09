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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>Information about the master playlist.</para>
    /// </summary>
    public class CreateJobPlaylist
    {
        
        private string name;
        private string format;
        private List<string> outputKeys = new List<string>();

        /// <summary>
        /// The name that you want Elastic Transcoder to assign to the master playlist, for example, nyc-vacation.m3u8. The name cannot include a /
        /// character. If you create more than one master playlist (not recommended), the values of all <c>Name</c> objects must be unique. Elastic
        /// Transcoder automatically appends .m3u8 to the file name. If you include .m3u8 in <c>Name</c>, it will appear twice in the file name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobPlaylist WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// This value must currently be HLSv3.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^HLSv3$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this.format; }
            set { this.format = value; }
        }

        /// <summary>
        /// Sets the Format property
        /// </summary>
        /// <param name="format">The value to set for the Format property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobPlaylist WithFormat(string format)
        {
            this.format = format;
            return this;
        }
            

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this.format != null;
        }

        /// <summary>
        /// For each output in this job that you want to include in a master playlist, the value of the <c>Outputs:Key</c> object. If you include more
        /// than one output in a playlist, the value of <c>SegmentDuration</c> for all of the outputs must be the same.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> OutputKeys
        {
            get { return this.outputKeys; }
            set { this.outputKeys = value; }
        }
        /// <summary>
        /// Adds elements to the OutputKeys collection
        /// </summary>
        /// <param name="outputKeys">The values to add to the OutputKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobPlaylist WithOutputKeys(params string[] outputKeys)
        {
            foreach (string element in outputKeys)
            {
                this.outputKeys.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the OutputKeys collection
        /// </summary>
        /// <param name="outputKeys">The values to add to the OutputKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobPlaylist WithOutputKeys(IEnumerable<string> outputKeys)
        {
            foreach (string element in outputKeys)
            {
                this.outputKeys.Add(element);
            }

            return this;
        }

        // Check to see if OutputKeys property is set
        internal bool IsSetOutputKeys()
        {
            return this.outputKeys.Count > 0;
        }
    }
}
