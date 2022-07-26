using Models;

namespace SandwichApp;

public class Machina
{
    
    private InputParser _inputParser;
    private InvoicePrinter _invoicePrinter;
    
    public Machina(InputParser inputParser, InvoicePrinter invoicePrinter)
    {
        _inputParser = inputParser;
        _invoicePrinter = invoicePrinter;
    }

    public ResponseCode ProcessCommand(String input)
    {
        Order order = _inputParser.ParseInput(input);
        if (!order.IsCompliant)
        {
            return ResponseCode.ErrorNoExit;
        }
        _invoicePrinter.PrintInvoice(order);
        return ResponseCode.Response200;
    }
}