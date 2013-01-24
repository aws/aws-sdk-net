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
using System.Text;

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
        /// <returns>
        /// A reference to this updated object so that method calls can be chained
        /// together.
        /// </returns>
        public ConfigureDaemons WithHeapSize(Daemon daemon, int megabytes)
        {
            args.Add("--" + daemon.ToString().ToLower() + "-heap-size=" + megabytes);
            return this;
        }

        /// <summary>
        /// Specify additional Java opts to be included when the daemon starts.
        /// </summary>
        /// <param name="daemon">The daemon to add opts to.</param>
        /// <param name="opts">Additional Java command line arguments.</param>
        /// <returns>
        /// A reference to this updated object so that method calls can be chained
        /// together.
        /// </returns>
        public ConfigureDaemons WithOpts(Daemon daemon, String opts)
        {
            args.Add("--" + daemon.ToString().ToLower() + "-opts=\"" + opts + "\"");
            return this;
        }

        /// <summary>
        /// Replace the existing hadoop-user-env.sh file if it exists.
        /// </summary>
        /// <param name="replace">whether the file should be replaced.</param>
        /// <returns>
        /// A reference to this updated object so that method calls can be chained
        /// together.
        /// </returns>
        public ConfigureDaemons WithReplace(bool replace)
        {
            this.replace = replace;
            return this;
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

            return new BootstrapActionConfig()
              .WithName("Configure Daemons")
              .WithScriptBootstrapAction(new ScriptBootstrapActionConfig()
                .WithPath("s3://" + bucket + "/bootstrap-actions/configure-daemons")
                .WithArgs(args.ToArray()));
        }
    }
}
