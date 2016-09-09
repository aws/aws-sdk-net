﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using Amazon.Runtime;
using ThirdParty.Json.LitJson;

namespace Amazon.Util
{
    /// <summary>
    /// This class can be used to discover the public address ranges for AWS. The 
    /// information is retrieved from the publicly accessible 
    /// https://ip-ranges.amazonaws.com/ip-ranges.json file.
    /// </summary>
    /// <remarks>
    /// The information in this file is generated from our internal system-of-record and 
    /// is authoritative. You can expect it to change several times per week and should 
    /// poll accordingly. 
    /// </remarks>
    public class AWSPublicIpAddressRanges
    {
        // The known-in-use service keys; the actual keys can be extended 
        // over time.
        public const string AmazonServiceKey = "AMAZON";
        public const string EC2ServiceKey = "EC2";
        public const string CloudFrontServiceKey = "CLOUDFRONT";
        public const string Route53ServiceKey = "ROUTE53";
        public const string Route53HealthChecksServiceKey = "ROUTE53_HEALTHCHECKS";

        /// <summary>
        /// Region identifier string for ROUTE53 and CLOUDFRONT ranges
        /// </summary>
        public const string GlobalRegionIdentifier = "GLOBAL";

#region Json parse keys
        const string createDateKey = "createDate";
        const string ipv4PrefixesKey = "prefixes";
        const string ipv4PrefixKey = "ip_prefix";
        const string ipv6PrefixesKey = "ipv6_prefixes";
        const string ipv6PrefixKey = "ipv6_prefix";
        const string regionKey = "region";
        const string serviceKey = "service";

        const string createDateFormatString = "yyyy-MM-dd-HH-mm-ss";
#endregion

        /// <summary>
        /// Collection of service keys found in the data file.
        /// </summary>
        public IEnumerable<string> ServiceKeys
        {
            get
            {
                var keyHash = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                foreach (var range in AllAddressRanges)
                {
                    keyHash.Add(range.Service);
                }

                return keyHash;
            }
        }

        /// <summary>
        /// The publication date and time of the file that was downloaded and parsed.
        /// </summary>
        public DateTime CreateDate { get; private set; }

        /// <summary>
        /// Collection of all public IP ranges.
        /// </summary>
        public IEnumerable<AWSPublicIpAddressRange> AllAddressRanges { get; private set; }

        /// <summary>
        /// Filtered collection of public IP ranges for the given service key
        /// </summary>
        public IEnumerable<AWSPublicIpAddressRange> AddressRangesByServiceKey(string serviceKey)
        {
            if (!AllAddressRanges.Any())
                throw new InvalidOperationException("No address range data has been loaded and parsed.");

            return AllAddressRanges.Where(ar => ar.Service.Equals(serviceKey, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Filtered collection of public IP ranges for the given region (us-east-1 etc) or GLOBAL.
        /// </summary>
        public IEnumerable<AWSPublicIpAddressRange> AddressRangesByRegion(string regionIdentifier)
        {
            if (!AllAddressRanges.Any())
                throw new InvalidOperationException("No address range data has been loaded and parsed.");

            return AllAddressRanges.Where(ar => ar.Region.Equals(regionIdentifier, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Downloads the most recent copy of the endpoint address file and
        /// parses it to a collection of address range objects.
        /// </summary>
        public static AWSPublicIpAddressRanges Load()
        {
            const int maxDownloadRetries = 3;

            var retries = 0;
            while (retries < maxDownloadRetries)
            {
                try
                {
                    // use async calls so same code works across mobile platforms
                    var request = WebRequest.Create(IpAddressRangeEndpoint) as HttpWebRequest;
                    var asynResult = request.BeginGetResponse(null, null);
                    var response = request.EndGetResponse(asynResult) as HttpWebResponse;

                    AWSPublicIpAddressRanges instance;
                    using (response)
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            instance = Parse(reader.ReadToEnd());
                        }
                    }

                    return instance;
                }
                catch (WebException e)
                {
                    retries++;
                    if (retries == maxDownloadRetries)
                        throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture, "Error downloading public IP address ranges file from {0}.", IpAddressRangeEndpoint), e);
                }

                var delay = (int) (Math.Pow(4, retries)*100);
                delay = Math.Min(delay, 30*1000);
                Util.AWSSDKUtils.Sleep(delay);
            }

            return null;
        }

        private static AWSPublicIpAddressRanges Parse(string fileContent)
        {
            try
            {
                var instance = new AWSPublicIpAddressRanges();

                var json = JsonMapper.ToObject(new JsonReader(fileContent));

                DateTime? creationDateTime = null;
                try
                {
                    var createdAt = (string)json[createDateKey];
                    creationDateTime = DateTime.ParseExact(createdAt, createDateFormatString, null);
                }
                catch (FormatException) { }
                catch (ArgumentNullException) { }

                instance.CreateDate = creationDateTime.GetValueOrDefault(DateTime.Now.ToUniversalTime());

                // ipv4 and v6 addresses occupy different keys in the data file and can't easily be merged
                // so process each subset separately
                var parsedRanges = new List<AWSPublicIpAddressRange>();
                var ipv4Ranges = json[ipv4PrefixesKey];
                var ipv6Ranges = json[ipv6PrefixesKey];
                if (!ipv4Ranges.IsArray || !ipv6Ranges.IsArray)
                    throw new InvalidDataException("Expected array content for ip_prefixes and/or ipv6_prefixes keys.");

                parsedRanges.AddRange(ParseRange(ipv4Ranges, AWSPublicIpAddressRange.AddressFormat.Ipv4));
                parsedRanges.AddRange(ParseRange(ipv6Ranges, AWSPublicIpAddressRange.AddressFormat.Ipv6));

                instance.AllAddressRanges = parsedRanges;
                return instance;
            }
            catch (Exception e)
            {
                throw new InvalidDataException("IP address ranges content in unexpected/invalid format.", e);
            }
        }

        private static IEnumerable<AWSPublicIpAddressRange> ParseRange(JsonData ranges, AWSPublicIpAddressRange.AddressFormat addressFormat)
        {
            var prefixKey = addressFormat == AWSPublicIpAddressRange.AddressFormat.Ipv4 
                    ? ipv4PrefixKey
                    : ipv6PrefixKey;

            var parsedRanges = new List<AWSPublicIpAddressRange>();
            parsedRanges.AddRange(from JsonData range in ranges
                select new AWSPublicIpAddressRange
                {
                    IpAddressFormat = addressFormat,
                    IpPrefix = (string)range[prefixKey],
                    Region = (string)range[regionKey],
                    Service = (string)range[serviceKey]
                });
            return parsedRanges;
        }

        private AWSPublicIpAddressRanges()
        {
        }

        private static readonly Uri IpAddressRangeEndpoint = new Uri("https://ip-ranges.amazonaws.com/ip-ranges.json");
    }

    /// <summary>
    /// Represents the IP address range for a single region and service key.
    /// </summary>
    public class AWSPublicIpAddressRange
    {
        /// <summary>
        /// The public IPv4 or Ipv6 address range, in CIDR notation.
        /// </summary>
        public string IpPrefix { get; internal set; }

        public enum AddressFormat
        {
            Ipv4,
            Ipv6
        }

        /// <summary>
        /// Indicates ipv4 or v6 format of the address
        /// </summary>
        public AddressFormat IpAddressFormat {  get; internal set; }

        /// <summary>
        /// The AWS region or GLOBAL for edge locations. Note that the CLOUDFRONT and ROUTE53 
        /// ranges are GLOBAL.
        /// </summary>
        public string Region { get; internal set; }

        /// <summary>
        /// The subset of IP address ranges. Specify AMAZON to get all IP address ranges 
        /// (for example, the ranges in the EC2 subset are also in the AMAZON subset). Note 
        /// that some IP address ranges are only in the AMAZON subset.
        /// </summary>
        /// <remarks>
        /// Valid values for the service key include "AMAZON", "EC2", "ROUTE53", 
        /// "ROUTE53_HEALTHCHECKS", and "CLOUDFRONT." If you need to know all of 
        /// the ranges and don't care about the service, use the "AMAZON" entries. 
        /// The other entries are subsets of this one. Also, some of the services, 
        /// such as S3, are represented in "AMAZON" and do not have an entry that 
        /// is specific to the service. We plan to add additional values over time; 
        /// code accordingly! 
        /// </remarks>
        public string Service { get; internal set; }
    }
}
