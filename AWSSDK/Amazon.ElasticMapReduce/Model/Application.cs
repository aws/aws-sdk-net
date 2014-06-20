/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// An application is any Amazon or third-party software that you can add to the cluster.
    /// This structure contains a list of strings that indicates the software to use with
    /// the cluster and accepts a user argument list. Amazon EMR accepts and forwards the
    /// argument list to the corresponding installation         script as bootstrap action
    /// argument. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-mapr.html">Launch
    /// a Job Flow on the MapR Distribution for Hadoop</a>. Currently supported values are:
    /// 
    ///       <ul>                 <li>"mapr-m3" - launch the job flow using MapR M3 Edition.</li>
    ///         <li>"mapr-m5" - launch the job flow using MapR M5 Edition.</li>         <li>"mapr"
    /// with the user arguments specifying "--edition,m3" or "--edition,m5" - launch the job
    /// flow using MapR M3 or M5 Edition, respectively.</li>      </ul>
    /// </summary>
    public partial class Application
    {
        private Dictionary<string, string> _additionalInfo = new Dictionary<string, string>();
        private List<string> _args = new List<string>();
        private string _name;
        private string _version;


        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// This option is for advanced users only. This is meta information about third-party
        /// applications that third-party vendors use for testing purposes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the AdditionalInfo dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the AdditionalInfo dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Application WithAdditionalInfo(params KeyValuePair<string, string>[] pairs)
        {
            foreach (KeyValuePair<string, string> pair in pairs)
            {
                this.AdditionalInfo[pair.Key] = pair.Value;
            }
            return this;
        }
        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null && this._additionalInfo.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// Arguments for Amazon EMR to pass to the application.
        /// </para>
        /// </summary>
        public List<string> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Application WithArgs(params string[] args)
        {
            foreach (var element in args)
            {
                this._args.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Application WithArgs(IEnumerable<string> args)
        {
            foreach (var element in args)
            {
                this._args.Add(element);
            }
            return this;
        }
        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && this._args.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Application WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the application.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }


        /// <summary>
        /// Sets the Version property
        /// </summary>
        /// <param name="version">The value to set for the Version property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Application WithVersion(string version)
        {
            this._version = version;
            return this;
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}