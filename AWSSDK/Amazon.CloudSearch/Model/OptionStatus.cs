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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The status of an option, including when it was last updated and whether it is actively in use for searches.</para>
    /// </summary>
    public class OptionStatus  
    {
        
        private DateTime? creationDate;
        private DateTime? updateDate;
        private int? updateVersion;
        private string state;

        /// <summary>
        /// A timestamp for when this option was created.
        ///  
        /// </summary>
        public DateTime CreationDate
        {
            get { return this.creationDate ?? default(DateTime); }
            set { this.creationDate = value; }
        }

        /// <summary>
        /// Sets the CreationDate property
        /// </summary>
        /// <param name="creationDate">The value to set for the CreationDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionStatus WithCreationDate(DateTime creationDate)
        {
            this.creationDate = creationDate;
            return this;
        }
            

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;       
        }

        /// <summary>
        /// A timestamp for when this option was last updated.
        ///  
        /// </summary>
        public DateTime UpdateDate
        {
            get { return this.updateDate ?? default(DateTime); }
            set { this.updateDate = value; }
        }

        /// <summary>
        /// Sets the UpdateDate property
        /// </summary>
        /// <param name="updateDate">The value to set for the UpdateDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionStatus WithUpdateDate(DateTime updateDate)
        {
            this.updateDate = updateDate;
            return this;
        }
            

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this.updateDate.HasValue;       
        }

        /// <summary>
        /// A unique integer that indicates when this option was last updated.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int UpdateVersion
        {
            get { return this.updateVersion ?? default(int); }
            set { this.updateVersion = value; }
        }

        /// <summary>
        /// Sets the UpdateVersion property
        /// </summary>
        /// <param name="updateVersion">The value to set for the UpdateVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionStatus WithUpdateVersion(int updateVersion)
        {
            this.updateVersion = updateVersion;
            return this;
        }
            

        // Check to see if UpdateVersion property is set
        internal bool IsSetUpdateVersion()
        {
            return this.updateVersion.HasValue;       
        }

        /// <summary>
        /// The state of processing a change to an option. Possible values:<ul> <li><c>RequiresIndexDocuments</c>: the option's latest value will not be
        /// visible in searches until <a>IndexDocuments</a> has been called and indexing is complete.</li> <li><c>Processing</c>: the option's latest
        /// value is not yet visible in all searches but is in the process of being activated. </li> <li><c>Active</c>: the option's latest value is
        /// completely visible. Any warnings or messages generated during processing are provided in <c>Diagnostics</c>.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>RequiresIndexDocuments, Processing, Active</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionStatus WithState(string state)
        {
            this.state = state;
            return this;
        }
            

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;       
        }
    }
}
