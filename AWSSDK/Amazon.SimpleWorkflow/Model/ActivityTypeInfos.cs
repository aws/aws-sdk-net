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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Contains a paginated list of activity type information structures. </para>
    /// </summary>
    public class ActivityTypeInfos
    {
        
        private List<ActivityTypeInfo> typeInfos = new List<ActivityTypeInfo>();
        private string nextPageToken;

        /// <summary>
        /// List of activity type information.
        ///  
        /// </summary>
        public List<ActivityTypeInfo> TypeInfos
        {
            get { return this.typeInfos; }
            set { this.typeInfos = value; }
        }
        /// <summary>
        /// Adds elements to the TypeInfos collection
        /// </summary>
        /// <param name="typeInfos">The values to add to the TypeInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ActivityTypeInfos WithTypeInfos(params ActivityTypeInfo[] typeInfos)
        {
            foreach (ActivityTypeInfo element in typeInfos)
            {
                this.typeInfos.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TypeInfos collection
        /// </summary>
        /// <param name="typeInfos">The values to add to the TypeInfos collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ActivityTypeInfos WithTypeInfos(IEnumerable<ActivityTypeInfo> typeInfos)
        {
            foreach (ActivityTypeInfo element in typeInfos)
            {
                this.typeInfos.Add(element);
            }

            return this;
        }

        // Check to see if TypeInfos property is set
        internal bool IsSetTypeInfos()
        {
            return this.typeInfos.Count > 0;
        }

        /// <summary>
        /// Returns a value if the results are paginated. To get the next page of results, repeat the request specifying this token and all other
        /// arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        /// <summary>
        /// Sets the NextPageToken property
        /// </summary>
        /// <param name="nextPageToken">The value to set for the NextPageToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ActivityTypeInfos WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }
    }
}
