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
using System.Globalization;
using System.Text;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// List of Hadoop daemons which can be configured.
    /// </summary>
    public enum Daemon
    {
        NameNode,
        DataNode,
        JobTracker,
        TaskTracker,
        Client
    }

    public class ConfigureDaemons
    {
        List<String> args = new List<String>();
        readonly string bucket;
        bool replace = false;

        internal ConfigureDaemons(string bucket)
        {
            this.bucket = bucket;
        }

        /// <summary>
        /// Set the heap size of a daemon.
        /// </summary>
        /// <param name="daemon">The deamon to configure.</param>
        /// <param name="megabytes">The requested heap size of the daemon.</param>
        public void AddHeapSize(Daemon daemon, int megabytes)
        {
            args.Add("--" + daemon.ToString().ToLower(CultureInfo.InvariantCulture) + "-heap-size=" + megabytes);
        }

        /// <summary>
        /// Specify additional Java opts to be included when the daemon starts.
        /// </summary>
        /// <param name="daemon">The daemon to add opts to.</param>
        /// <param name="opts">Additional Java command line arguments.</param>
        public void AddOpts(Daemon daemon, String opts)
        {
            args.Add("--" + daemon.ToString().ToLower(CultureInfo.InvariantCulture) + "-opts=\"" + opts + "\"");
        }

        /// <summary>
        /// Replace the existing hadoop-user-env.sh file if it exists.
        /// </summary>
        public bool Replace 
        {
            get { return  this.replace; }
            set { this.replace = value; }
        }

        /// <summary>
        /// Returns an object which can be used in a RunJobflow call.
        /// </summary>
        /// <returns>an object which can be used in a RunJobflow call.</returns>
        public BootstrapActionConfig Build()
        {
            if (replace)
            {
                args.Add("--replace");
            }

            return new BootstrapActionConfig
            {
                Name = "Configure Daemons",
                ScriptBootstrapAction = new ScriptBootstrapActionConfig
                {
                    Path = string.Format(CultureInfo.InvariantCulture, "s3://{0}/bootstrap-actions/configure-daemons", bucket),
                    Args = args
                }
            };
        }
    }
}
