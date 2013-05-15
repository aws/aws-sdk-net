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
    /// 
    /// </summary>
    public class Playlist
    {
        
        private string name;
        private string format;
        private List<string> outputKeys = new List<string>();
        private string status;
        private string statusDetail;

        /// <summary>
        /// 
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
        public Playlist WithName(string name)
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
        /// 
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
        public Playlist WithFormat(string format)
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
        /// 
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
        public Playlist WithOutputKeys(params string[] outputKeys)
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
        public Playlist WithOutputKeys(IEnumerable<string> outputKeys)
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

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Submitted$)|(^Progressing$)|(^Complete$)|(^Canceled$)|(^Error$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public Playlist WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StatusDetail
        {
            get { return this.statusDetail; }
            set { this.statusDetail = value; }
        }

        /// <summary>
        /// Sets the StatusDetail property
        /// </summary>
        /// <param name="statusDetail">The value to set for the StatusDetail property </param>
        /// <returns>this instance</returns>
        public Playlist WithStatusDetail(string statusDetail)
        {
            this.statusDetail = statusDetail;
            return this;
        }
            

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this.statusDetail != null;
        }
    }
}
