﻿using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
using System.ServiceModel;

namespace AxoCover.Common.Runner
{
  [ServiceContract]
  public interface ITestDiscoveryMonitor
  {
    [OperationContract(IsOneWay = true)]
    void RecordMessage(TestMessageLevel testMessageLevel, string message);

    [OperationContract(IsOneWay = true)]
    void RecordResults(TestCase[] testCases);
  }
}
